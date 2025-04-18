﻿using MediatR;

namespace DevFreela.Application.Notification.ProjectCreated
{
    internal class GenerateProjectBoardHandler : INotificationHandler<ProjectCreatedNotification>
    {
        public Task Handle(ProjectCreatedNotification notification, CancellationToken cancellationToken)
        {
            Console.WriteLine($"Criadno painel para o projeto {notification.Title}");

            return Task.CompletedTask;
        }
    }
}
