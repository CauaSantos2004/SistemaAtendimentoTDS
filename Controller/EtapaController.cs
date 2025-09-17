using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaAtendimento.Model;
using SistemaAtendimento.Repositories;
using SistemaAtendimento.View;

namespace SistemaAtendimento.Controller
{
    public class EtapaController
    {
        private FrmCadastroEtapa _frmCadastroEtapa;
        private EtapaRepository _etapaRepository;

        public EtapaController(FrmCadastroEtapa view)
        {
            _frmCadastroEtapa = view;
            _etapaRepository = new EtapaRepository();
        }

        public void ListarEtapas()
        {
            try
            {
                var listarEtapas = _etapaRepository.Listar();
                _frmCadastroEtapa.ExibirEtapas(listarEtapas);
            }
            catch (Exception ex) // se der erro
            {
                _frmCadastroEtapa.ExibirMensagem($"Erro ao carregar Etapas: {ex.Message}");

            }
        }
        public void Salvar(Etapas etapas)
        {
            //criar o try catch
            try
            {
                _etapaRepository.Inserir(etapas);
                _frmCadastroEtapa.ExibirMensagem($"Etapa cadastrada com sucesso!");

                ListarEtapas();
                //Atualizar DataGrid

                _frmCadastroEtapa.DesabilitarCampos();
            }
            catch (Exception ex)
            {
                _frmCadastroEtapa.ExibirMensagem($"Erro ao cadastrar o etapa: {ex.Message}");
            }
        }

    }   
}
