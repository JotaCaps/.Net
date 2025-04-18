﻿using DevFreela.Application.Models;
using DevFreela.Core.Repositories;
using DevFreela.Infrastructure.Persistence;
using MediatR;

namespace DevFreela.Application.Commands.InsertProject
{
    public class InsertProjectHandler : IRequestHandler<InsertProjectCommand, ResultViewModel<int>>
    {
        private readonly IProjectRepository _repository;

        public InsertProjectHandler(DevFreelaDbContext context, IProjectRepository repository)
        {
            _repository = repository;
        }

        public async Task<ResultViewModel<int>> Handle(InsertProjectCommand request, CancellationToken cancellationToken)
        {
            var project = request.ToEntity();

            await _repository.Add(project);

            return ResultViewModel<int>.Sucess(project.Id);
        }
    }
}
