using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using GestaoHospital.WebAPI.Data.Dtos;
using GestaoHospital.WebAPI.Data.Repositories.Mapas;
using GestaoHospital.WebAPI.Data.Repositories.Usuarios;
using GestaoHospital.WebAPI.Models;
using GestaoHospital.WebAPI.Models.Usuario;
using GestaoHospital.WebAPI.Paginations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GestaoHospital.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class UsuarioController : ControllerBase
    {
        public readonly IRepositoryUsuario _repo;
        public readonly IRepositoryPerfil _repoPerfil;
        public readonly IMapper _mapper;

        public UsuarioController(
            IRepositoryUsuario repo,
            IMapper mapper,
            IRepositoryPerfil repoPerfil
        )
        {
            _repo = repo;
            _mapper = mapper;
            _repoPerfil = repoPerfil;
        }

        [HttpPost]
        public async Task<IActionResult> Get([FromBody] RequestData<GetUsuariosFilterDto> request)
        {
            var (usuarios, count) = await _repo.GetAllUsusariosAsync(request);
            var usuariosResult = _mapper.Map<IEnumerable<GetUsuarioDto>>(usuarios);
            if (!usuariosResult.ToList().Any())
            {
                return BadRequest("Nenhum usuário encontrado.");
            }
            var result = new ResponseData<IEnumerable<GetUsuarioDto>>
            {
                Data = usuariosResult,
                MetaData = new ResponseMetaData(
                    totalCount: count,
                    pageSize: request.PageSize,
                    pageNumber: request.PageNumber
                )
            };
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Create(PostUsuarioDto model)
        {
            var usuario = _mapper.Map<EntityUsuario>(model);

            if (model.IdPerfil.HasValue)
            {
                EntityPerfil perfil = _repoPerfil.GetById(model.IdPerfil.Value);
                if (perfil != null)
                {
                    usuario.Perfil = perfil;
                }
            }
            _repo.Add(usuario);
            if (_repo.SaveChanges())
            {
                return Created($"/api/usuario/{usuario.Id}", _mapper.Map<GetUsuarioDto>(usuario));
            }

            return BadRequest("Usuario não cadastrado");
        }
    }
}
