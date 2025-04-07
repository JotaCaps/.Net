using DevFreela.Aplication.Models;
using DevFreela.Application.Models;
using MediatR;

namespace DevFreela.Application.Queries.GetAllProjects
{
    public class GetAllProjectsQuerie : IRequest<ResultViewModel<List<ProjectItemViewModel>>>
    {

    }
}

