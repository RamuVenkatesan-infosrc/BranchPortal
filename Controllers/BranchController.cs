using BranchPortal.Data;
using BranchPortal.Dto;
using BranchPortal.Dto.BranchPortal.Dto;
using BranchPortal.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BranchPortal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BranchController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;

        public BranchController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult GetBranches()
        {
            return Ok(_dbContext.Branches);
        }

        [HttpGet]
        [Route("{id:guid}")]
        public IActionResult GetBranchById(Guid id)
        {
            var branch = _dbContext.Branches.Find(id);
            if (branch == null)
            {
                return NotFound();
            }
            return Ok(branch);
        }

        [HttpPost]
        public IActionResult AddBranch(BranchDto branchDto)
        {
            var branch = new Branch
            {
                Id = Guid.NewGuid(),
                Name = branchDto.Name,
                Location = branchDto.Location,
                ManagerName = branchDto.ManagerName
            };
            _dbContext.Branches.Add(branch);
            _dbContext.SaveChanges();
            return StatusCode(StatusCodes.Status201Created);
        }

        [HttpPut]
        [Route("{id:guid}")]
        public IActionResult UpdateBranch(Guid id, UpdateBranchDto branchDto)
        {
            var branch = _dbContext.Branches.Find(id);
            if (branch == null)
            {
                return NotFound();
            }

            branch.Name = branchDto.Name;
            branch.Location = branchDto.Location;
            branch.ManagerName = branchDto.ManagerName;

            _dbContext.SaveChanges();
            return Ok(branch);
        }

        [HttpDelete]
        [Route("{id:guid}")]
        public IActionResult DeleteBranch(Guid id)
        {
            var branch = _dbContext.Branches.Find(id);
            if (branch == null)
            {
                return NotFound();
            }

            _dbContext.Branches.Remove(branch);
            _dbContext.SaveChanges();
            return NoContent();
        }
    }
}
