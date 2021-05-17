using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Projet.Business.DTO;
using Projet.Data.Models;
using Projet.Data.Repositories;

namespace Projet.Business.Services
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository clientRepository;

        public ClientService(IClientRepository repository)
        {
            clientRepository = repository;
        }

        public async Task<ClientDto> AddClient(ClientDto clientDto)
        {
            Client client = DtoToModel(clientDto);
            client.DateCreation = DateTime.Now;

            await clientRepository.AddClient(client);
            ClientDto dto = ModelToDto(client);

            return dto;
        }

        public async Task<ClientDto> UpdateClient(ClientDto clientDto)
        {
            Client client = DtoToModel(clientDto);
            await clientRepository.UpdateClient(client);
            ClientDto dto = ModelToDto(client);

            return dto;
        }

        public async Task<ClientDto> GetClient(int id)
        {
            Client client = await clientRepository.GetClient(id);
            ClientDto clientDto = ModelToDto(client);
            return clientDto;
        }

        public List<ClientDto> GetAllClients()
        {
            List<Client> clients = clientRepository.GetAllClients();
            List<ClientDto> clientsDto = ListModelToDto(clients);
            return clientsDto;
        }

        public async Task<int> DeleteClient(int id)
        {
            return await clientRepository.DeleteClient(id);
        }

        private ClientDto ModelToDto(Client client)
        {
            ClientDto clientDto = new ClientDto
            {
                Id = client.Id,
                Nom = client.Nom,
                Prenom = client.Prenom,
                Mail = client.Mail,
                DateCreation = client.DateCreation,
            };

            return clientDto;
        }

        private Client DtoToModel(ClientDto dto)
        {
            Client client = new Client
            {
                Id = dto.Id,
                Nom = dto.Nom,
                Prenom = dto.Prenom,
                Mail = dto.Mail,
                DateCreation = dto.DateCreation
            };

            return client;
        }

        private List<ClientDto> ListModelToDto(ICollection<Client> shopItems)
        {
            List<ClientDto> shopItemDtos = shopItems.Select(x => ModelToDto(x)).ToList();
            return shopItemDtos;
        }
    }
}
