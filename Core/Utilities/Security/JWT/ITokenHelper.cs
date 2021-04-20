﻿using Core.Entities.Concrete;
using Entities.Concrete;
using System.Collections.Generic;

namespace Core.Utilities.Security.JWT
{
    public interface ITokenHelper
    {
        AccessToken CreateToken(User user, List<OperationClaim> operationClaims); // Doğrulama işlemleri başarılı olduktan sonra burası çalışacak.
    }
}
