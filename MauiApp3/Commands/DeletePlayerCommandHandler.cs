using MauiApp3.Data;
using MauiApp3.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MauiApp3.Commands
{
    public class DeletePlayerCommandHandler
    {
        private readonly PlayerRepository _playerRepository;
        public DeletePlayerCommandHandler(PlayerRepository playerRepository)
        {
            _playerRepository = playerRepository;
        }

        public void Handle(DeletePlayerCommand command)
        {
            Player? player = _playerRepository.Players
                .FirstOrDefault(p => p.Id == command.Id);

            if (player == null)
            {
                return;
            }

            _playerRepository.Players.Remove(player);
        }
    }
}
