﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeAcademy.Areas.Editor.Models.ViewModels;
using CodeAcademy.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CodeAcademy.Areas.Editor.Controllers
{
    [Authorize(Roles = "Editor")]
    [Area("Editor")]
    public class GroupController : Controller
    {
        AppDbContext _dbContext;

        public GroupController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var groups = _dbContext.Groups
                .Select(x => new GroupViewModel()
                {
                    Id = x.Id,
                    FacultyId = x.FacultyId,
                    LessonsStartDate = x.LessonsStartDate,
                    Name = x.Name,
                    RoomId = x.RoomId,
                    LessonsEndDate = x.LessonsEndDate
                }).ToList();

            return View(groups);
        }

        public async Task<IActionResult> Create()
        {
            return View();
        }
    }
}