using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using GestaoHospital.WebAPI.Data;
using GestaoHospital.WebAPI.Data.Dtos;
using GestaoHospital.WebAPI.Models;
using GestaoHospital.WebAPI.Paginations;
using Microsoft.AspNetCore.Mvc;

namespace GestaoHospital.WebAPI.Controllers
{
    [ApiController]
    
    [Route("api/[controller]/[action]")]
    public class MapaController : ControllerBase
    {
        public readonly IRepository _repo;
        public readonly IMapper _mapper;

        public MapaController(IRepository repo ,IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }
        [HttpPost]
        public async Task<IActionResult> ObterMapas([FromBody] RequestData<GetMapasFilterDto> request){
            var (mapas,count) = await _repo.GetAllMapasAsync(request);
            var mapasResult = _mapper.Map<IEnumerable<MapaDto>>(mapas);
            var result = new ResponseData<IEnumerable<MapaDto>>
            {
                Data = mapasResult,
                MetaData = new ResponseMetaData(
                    totalCount: count,
                    pageSize: request.PageSize,
                    pageNumber: request.PageNumber
                )
            };
            return Ok( result );
        }
        [HttpPost]
        public IActionResult CriarMapa(MapaDto model) {
            var mapa = _mapper.Map<Mapa>(model);

            _repo.Add(mapa);
            if (_repo.SaveChanges())
            {
                return Created($"/api/mapa/{model.Id}", _mapper.Map<MapaDto>(mapa));
            }

            return BadRequest("Mapa não cadastrado");
        }
        
    }
}