using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Identity.Client;
using SistemaAtendimento.Model;
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
        public void Atualizar(Etapas etapa) //método de atualizar
        {
            //criar o try catch
            try
            {
                _EtapasRepository.Atualizar(etapa);
                _frmCadastroEtapas.ExibirMensagem($"Etapa atualizada com sucesso!");

                ListarEtapas();
                //Atualizar DataGrid

                _frmCadastroEtapas.DesabilitarCampos();
            }
            catch (Exception ex)
            {
                _frmCadastroEtapas.ExibirMensagem($"Erro ao atualizar etapa: {ex.Message}");
            }
        }

        public void Excluir(int id) //método de excluir
        {
            try
            {
                _EtapasRepository.Excluir(id); // ✅ chama o método certo

                _frmCadastroEtapas.ExibirMensagem("Etapa excluída com sucesso!");

                ListarEtapas(); // atualiza a lista na tela
                _frmCadastroEtapas.DesabilitarCampos();
            }
            catch (Exception ex)
            {
                _frmCadastroEtapas.ExibirMensagem($"Erro ao excluir a etapa: {ex.Message}");
            }

        }

        public void Inserir(Etapas etapa)
        {
            try
            {
                _EtapasRepository.Inserir(etapa);
                _frmCadastroEtapas.ExibirMensagem("Etapa cadastrada com sucesso!");
                ListarEtapas(); // atualiza a lista após inserir
                _frmCadastroEtapas.DesabilitarCampos();
            }
            catch (Exception ex)
            {
                _frmCadastroEtapas.ExibirMensagem($"Erro ao cadastrar etapa: {ex.Message}");
            }
        }




    }
}