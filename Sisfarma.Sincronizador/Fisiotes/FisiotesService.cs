﻿using Sisfarma.Sincronizador.Fisiotes.Repositories;

namespace Sisfarma.Sincronizador.Fisiotes
{
    public class FisiotesService
    {
        //private string _server, _database;
        private readonly FisiotesContext _ctx;

        public ClientesRepository Clientes { get; private set; }

        public HuecosRepository Huecos { get; private set; }

        public PuntosPendientesRepository PuntosPendientes { get; private set; }

        public ConfiguracionesRepository Configuraciones { get; private set; }

        public EntregasRepository Entregas { get; private set; }

        public MedicamentosRepository Medicamentos { get; private set; }

        public SinonimosRepository Sinonimos { get; private set; }

        public PedidosRepository Pedidos { get; private set; }

        public ListasRepository Listas { get; private set; }

        public CategoriasRepository Categorias { get; set; }

        public EncargosRepository Encargos { get; set; }

        public FamiliasRepository Familias { get; set; }

        public FaltasRepository Faltas { get; set; }

        public FisiotesService(string host, string username, string password)
        {                        
            //Listas = new ListasRepository(_ctx);            
            var restClient = new RestClient.RestSharp.RestClient();
            var config = FisiotesConfig.TestConfig(host, username, password);
            Clientes = new ClientesRepository(restClient, config);
            Huecos = new HuecosRepository(restClient, config);
            PuntosPendientes = new PuntosPendientesRepository(restClient, config);
            Configuraciones = new ConfiguracionesRepository(restClient, config);
            Entregas = new EntregasRepository(restClient, config);
            Medicamentos = new MedicamentosRepository(restClient, config);
            Sinonimos = new SinonimosRepository(restClient, config);
            Pedidos = new PedidosRepository(restClient, config);
            Faltas = new FaltasRepository(restClient, config);
            Familias = new FamiliasRepository(restClient, config);
            Encargos = new EncargosRepository(restClient, config);
            Categorias = new CategoriasRepository(restClient, config);
        }
    }
}