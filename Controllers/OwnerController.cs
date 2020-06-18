﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using myTestCICD.Contracts;

namespace myTestCICD.Controllers
{
    [ApiController]
    [Route("api/owner")]
    public class OwnerController : ControllerBase
    {
        private IRepositoryWrapper _repository;

        public OwnerController(IRepositoryWrapper repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult GetAllOwners()
        {
            //return StatusCode(500);
            //return NotFound();//404
            try
            {
                //var ownersfd = _repository.Owner.FindAll();
                var owners = _repository.Owner.GetAllOwners();

                return Ok(owners);
                //return Ok(owners);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }



        //[ApiController]
        //[Route("api/owner")]
        //public class OwnerController : ControllerBase
        //{
        //    private ILoggerManager _logger;
        //    private IRepositoryWrapper _repository;
        //    private IMapper _mapper;

        //    public OwnerController(ILoggerManager logger, IRepositoryWrapper repository, IMapper mapper)
        //    {
        //        _logger = logger;
        //        _repository = repository;
        //        _mapper = mapper;
        //    }

        //    //uses pagination via OwnerParameters
        //    [HttpGet]
        //    public IActionResult GetOwners([FromQuery] OwnerParameters ownerParameters)
        //    {
        //        var owners = _repository.Owner.GetOwners(ownerParameters);

        //        _logger.LogInfo($"Returned {owners.Count()} owners from database.");

        //        return Ok(owners);
        //    }



        //    [HttpGet("{id}", Name = "OwnerById")]//[HttpGet("{id}")]
        //    public IActionResult GetOwnerById(Guid id)
        //    {
        //        try
        //        {
        //            var owner = _repository.Owner.GetOwnerById(id);

        //            if (owner == null)
        //            {
        //                _logger.LogError($"Owner with id: {id}, hasn't been found in db.");
        //                return NotFound();
        //            }
        //            else
        //            {
        //                _logger.LogInfo($"Returned owner with id: {id}");

        //                var ownerResult = _mapper.Map<OwnerDto>(owner);
        //                return Ok(ownerResult);
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            _logger.LogError($"Something went wrong inside GetOwnerById action: {ex.Message}");
        //            return StatusCode(500, "Internal server error");
        //        }
        //    }

        //    [HttpGet("{id}/account")]
        //    public IActionResult GetOwnerWithDetails(Guid id)
        //    {
        //        try
        //        {
        //            var owner = _repository.Owner.GetOwnerWithDetails(id);

        //            if (owner == null)
        //            {
        //                _logger.LogError($"Owner with id: {id}, hasn't been found in db.");
        //                return NotFound();
        //            }
        //            else
        //            {
        //                _logger.LogInfo($"Returned owner with details for id: {id}");

        //                var ownerResult = _mapper.Map<OwnerDto>(owner);

        //                return Ok(ownerResult);
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            _logger.LogError($"Something went wrong inside GetOwnerWithDetails action: {ex.Message}");
        //            return StatusCode(500, "Internal server error");
        //        }
        //    }


        //    [HttpPost]
        //    public IActionResult CreateOwner([FromBody]OwnerForCreationDto owner)
        //    {
        //        try
        //        {
        //            if (owner == null)
        //            {
        //                _logger.LogError("Owner object sent from client is null.");
        //                return BadRequest("Owner object is null");
        //            }

        //            if (!ModelState.IsValid)
        //            {
        //                _logger.LogError("Invalid owner object sent from client.");
        //                return BadRequest("Invalid model object");
        //            }

        //            var ownerEntity = _mapper.Map<Owner>(owner);

        //            _repository.Owner.CreateOwner(ownerEntity);
        //            _repository.Save();

        //            var createdOwner = _mapper.Map<OwnerDto>(ownerEntity);

        //            return CreatedAtRoute("OwnerById", new { id = createdOwner.Id }, createdOwner);
        //        }
        //        catch (Exception ex)
        //        {
        //            _logger.LogError($"Something went wrong inside CreateOwner action: {ex.Message}");
        //            return StatusCode(500, "Internal server error");
        //        }
        //    }

        //    [HttpPut("{id}")]
        //    public IActionResult UpdateOwner(Guid id, [FromBody]OwnerForUpdateDto owner)
        //    {
        //        try
        //        {
        //            if (owner == null)
        //            {
        //                _logger.LogError("Owner object sent from client is null.");
        //                return BadRequest("Owner object is null");
        //            }

        //            if (!ModelState.IsValid)
        //            {
        //                _logger.LogError("Invalid owner object sent from client.");
        //                return BadRequest("Invalid model object");
        //            }

        //            var ownerEntity = _repository.Owner.GetOwnerById(id);
        //            if (ownerEntity == null)
        //            {
        //                _logger.LogError($"Owner with id: {id}, hasn't been found in db.");
        //                return NotFound();
        //            }

        //            _mapper.Map(owner, ownerEntity);

        //            _repository.Owner.UpdateOwner(ownerEntity);
        //            _repository.Save();

        //            return NoContent();
        //        }
        //        catch (Exception ex)
        //        {
        //            _logger.LogError($"Something went wrong inside UpdateOwner action: {ex.Message}");
        //            return StatusCode(500, "Internal server error");
        //        }
        //    }

        //    [HttpDelete("{id}")]
        //    public IActionResult DeleteOwner(Guid id)
        //    {
        //        try
        //        {
        //            var owner = _repository.Owner.GetOwnerById(id);
        //            if (owner == null)
        //            {
        //                _logger.LogError($"Owner with id: {id}, hasn't been found in db.");
        //                return NotFound();
        //            }

        //            if (_repository.Account.AccountsByOwner(id).Any())
        //            {
        //                _logger.LogError($"Cannot delete owner with id: {id}. It has related accounts. Delete those accounts first");
        //                return BadRequest("Cannot delete owner. It has related accounts. Delete those accounts first");
        //            }

        //            _repository.Owner.DeleteOwner(owner);
        //            _repository.Save();

        //            return NoContent();
        //        }
        //        catch (Exception ex)
        //        {
        //            _logger.LogError($"Something went wrong inside DeleteOwner action: {ex.Message}");
        //            return StatusCode(500, "Internal server error");
        //        }
        //    }



        //}


    }
}
