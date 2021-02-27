using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers
{
    public class ActivitiesController : BaseApiController
    {
        private readonly DataContext _contex;
        public ActivitiesController(DataContext contex)
        {
            _contex = contex;
        }

        [HttpGet]
        public async Task<ActionResult<List<Activity>>> GetActivity()
        {
            return await _contex.Activities.ToListAsync();
        }

        [HttpGet("{id}")] // activity
        public async Task<ActionResult<Activity>> GetActivity(Guid id)
        {
            return await _contex.Activities.FindAsync(id);
        }

    }
}