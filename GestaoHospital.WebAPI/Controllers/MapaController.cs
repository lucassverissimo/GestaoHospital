using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using GestaoHospital.WebAPI.Data.Dtos;
using GestaoHospital.WebAPI.Data.Repositories.Mapas;
using GestaoHospital.WebAPI.Models;
using GestaoHospital.WebAPI.Paginations;
using Microsoft.AspNetCore.Mvc;

namespace GestaoHospital.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class MapaController : ControllerBase
    {
        public readonly IRepositoryMapa _repo;
        public readonly IMapper _mapper;

        public MapaController(IRepositoryMapa repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> Get([FromBody] RequestData<GetMapasFilterDto> request)
        {
            var (mapas, count) = await _repo.GetAllMapasAsync(request);
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
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Create(MapaDto model)
        {
            var mapa = _mapper.Map<EntityMapa>(model);

            _repo.Add(mapa);
            if (_repo.SaveChanges())
            {
                return Created($"/api/mapa/{model.Id}", _mapper.Map<MapaDto>(mapa));
            }

            return BadRequest("Mapa não cadastrado");
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, MapaDto model)
        {
            var mapa = _mapper.Map<EntityMapa>(model);
            _repo.Update(mapa);
            if (_repo.SaveChanges())
            {
                return Ok("Mapa atualizado");
            }

            return BadRequest("Mapa não atualizado");
        }
    }
}
