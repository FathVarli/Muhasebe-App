using MuhasebeApp.Core.Utils.Results;
using MuhasebeApp.Entity;
using MuhasebeApp.Entity.Concrete;
using MuhasebeApp.Entity.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace MuhasebeApp.Business.Abstract
{
    public interface IKullaniciService
    {
        IResult Register(RegisterDto registerDto);

        IResult Login(LoginDto loginDto);


    }
}
