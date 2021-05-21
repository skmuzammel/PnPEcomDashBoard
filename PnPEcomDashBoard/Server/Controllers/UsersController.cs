using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PnPEcomDashBoard.Shared.Models;
using PnPEcomDashBoard.Server.Data;
using Microsoft.EntityFrameworkCore;

namespace PnPEcomDashBoard.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly PnPContext _pnPContext;

        public UsersController(PnPContext pnPContext)
        {
            _pnPContext = pnPContext;
        }

        [HttpGet]
        public async Task<IEnumerable<User>> Get()
        {
            return await _pnPContext.Users.ToListAsync();
        }
    }
}
