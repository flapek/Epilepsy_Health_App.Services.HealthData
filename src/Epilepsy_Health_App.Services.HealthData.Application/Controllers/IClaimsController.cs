﻿using System;

namespace Epilepsy_Health_App.Services.HealthData.Application.Controllers
{
    public interface IClaimsController
    {
        Guid GetUserId(string jwt);
    }
}
