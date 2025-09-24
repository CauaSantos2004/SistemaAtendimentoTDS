using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaAtendimento.Repositories;
using SistemaAtendimento.View;

namespace SistemaAtendimento.Controller
{
    public class EtapasController
    {
        public FrmCadastroEtapa _frmCadastroEtapas;
        public EtapasRepository _EtapasRepository;

        public EtapasController(FrmCadastroEtapa view)
        {
            _frmCadastroEtapas = view;
            _EtapasRepository = new EtapasRepository();
        }
        public void ListarEtapas()
        {
            try
            {
                var listaretapas = _EtapasRepository.Listar();

                _frmCadastroEtapas.ExibirEtapas(listaretapas);
            }
            catch (Exception ex)
            {
                _frmCadastroEtapas.ExibirMensagem($"erro ao carregar as etapas: {ex.Message}");
            }
            // catch (Exception ex)
            {
                // _frmCadastroEtapas.ExibirMensagem($"erro ao Cadastrar o Clientes: {ex.Message}");
            }


        }
    }
}