using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apiPDV.repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using apiPDV.model;
using apiPDV.calculator;

namespace apiPDV.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ChangeController : ControllerBase
    {
        private readonly IChangeRepository _changeRepository;


        public ChangeController(IChangeRepository context)
        {
            this._changeRepository = context;
        }
        //[Route("[action]/lista")]
        [HttpGet]
        public IEnumerable<Change> Get()
        {
            return this._changeRepository.GetAll();
        }
        [HttpPost]  
        public IActionResult create([FromBody]Change change)
        {
            if(change == null)
            {
                return BadRequest();
            }
            
            ChangeCaculator changeCaculator = new ChangeCaculator();

            String notesUnused =  changeCaculator.changeCaculator(change.value);
            change.Note = notesUnused;
            this._changeRepository.add(change);
            var uri = Url.Action("Get", new { id = change.Id });
            return Created(uri, change);
        }
        [HttpGet("id")]
        public IActionResult getById(long id)
        {
            var change = this._changeRepository.find(id);
            if(change == null)
            {
                return NotFound();
            }
            return new OkObjectResult(change);
        }

        [HttpPut("{id}")]
        public IActionResult Update(long id, [FromBody]Change change)
        {
            if (change == null || change.Id != id)
                return BadRequest();

            var _change = this._changeRepository.find(id);
            if (_change == null)
                return NotFound();

            _change.value = change.value;
            _change.Note = change.Note;

            _changeRepository.update(_change);
            return new NoContentResult();
        }
        
    }
    }