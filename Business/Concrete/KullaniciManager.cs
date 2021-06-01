using MuhasebeApp.Business.Abstract;
using MuhasebeApp.Core.Utils.Results;
using MuhasebeApp.Core.Utils.Security;
using MuhasebeApp.DataAccess.Abstract;
using MuhasebeApp.Entity;
using MuhasebeApp.Entity.Concrete;
using MuhasebeApp.Entity.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace MuhasebeApp.Business.Concrete
{
    public class KullaniciManager : IKullaniciService
    {
        private IKullaniciDal _kullaniciDal;

        public KullaniciManager(IKullaniciDal kullaniciDal)
        {
            _kullaniciDal = kullaniciDal;
        }

        public IResult Login(LoginDto loginDto)
        {
            Kullanici checkUser = _kullaniciDal.Get(u => u.Tc == loginDto.Tc);
            if(checkUser == null)
            {
                return new ErrorResult("Kullanici bulunamadı!");
            }
            if (!HashingHelper.VerifyPasswordHash(loginDto.Sifre, checkUser.PasswordHash, checkUser.PasswordSalt))
            {
                return new ErrorResult("Kullanıcı adi veya şifre hatali!");
            }

            return new SuccessResult();
        }

        public IResult Register(RegisterDto registerDto)
        {
            Kullanici existKullanici = _kullaniciDal.Get(u => u.Tc == registerDto.Tc);
            if(existKullanici != null)
            {
                return new ErrorResult("Bu tc numarası kullanılıyor!");
            }
            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash(registerDto.Sifre, out passwordHash, out passwordSalt);
            var newKullanici = new Kullanici {
                Ad = registerDto.Ad,
                Soyad = registerDto.Soyad,
                Tc = registerDto.Tc,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt
            };

            _kullaniciDal.Add(newKullanici);
            return new SuccessResult("Kullanici kaydi başarıyla yapılmıştır.");

        }
    }
}
