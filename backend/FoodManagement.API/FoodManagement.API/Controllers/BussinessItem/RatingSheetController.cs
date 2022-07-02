﻿
using FoodManagement.Core.Consts;
using FoodManagement.Core.Entities.BussinessItem;
using FoodManagement.Core.General.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FoodManagement.Core.Interfaces.Infrastructure.IRepository.BussinessItem;
using FoodManagement.Core.Interfaces.Infrastructure.IService.BussinessItem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodManagement.API.Controllers.BussinessItem
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class RatingSheetController : BaseSubjectController<RatingSheet>
    {
        #region Fields
        IRatingSheetRepository _RatingSheetRepository;
        IRatingSheetService _RatingSheetService;
        #endregion
        public RatingSheetController(IRatingSheetRepository RatingSheetRepository, IRatingSheetService RatingSheetService) :base(RatingSheetRepository, RatingSheetService)
        {
            _RatingSheetRepository = RatingSheetRepository;
            _RatingSheetService = RatingSheetService;
            serviceResult = new ServiceResult();
            _const = new EnumResource();
        }

    }
}
