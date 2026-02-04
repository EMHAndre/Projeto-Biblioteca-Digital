using Library1.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Library1.DataAccess
{
    // Interface para modelos que possuem ID
    public interface IModeloComId
    {
        int Id { get; set; }
    }

    public class TextConnector : IDataConnection
    {
        // ========================
        // MÉTODO AUXILIAR: GERA O PRÓXIMO ID
        // ========================
        private int ObterProximoId<T>(List<T> itens) where T : IModeloComId
        {
            return itens.Count == 0 ? 1 : itens.Max(x => x.Id) + 1;
        }

        // ========================
        // MÉTODOS AUXILIARES PARA CARREGAR E SALVAR LISTAS
        // ========================
        private List<T> CarregarLista<T>() where T : IModeloComId
        {
            string arquivo;

            if (typeof(T) == typeof(PersonModel))
                arquivo = GlobalConfig.PeopleFile;
            else if (typeof(T) == typeof(TeamModel))
                arquivo = GlobalConfig.TeamsFile;
            else if (typeof(T) == typeof(PrizeModel))
                arquivo = GlobalConfig.PrizesFile;
            else if (typeof(T) == typeof(TournamentModel))
                arquivo = GlobalConfig.TournamentsFile;
            else
                throw new Exception("Tipo de modelo não suportado.");

            var linhas = arquivo.FullFilePath().LoadFile();

            if (typeof(T) == typeof(PersonModel))
                return linhas.ConvertToPersonModels() as List<T>;
 
            else if (typeof(T) == typeof(PrizeModel))
                return linhas.ConvertToPrizeModels() as List<T>;
            else if (typeof(T) == typeof(TournamentModel))
                return linhas.ConvertToTournamentModels() as List<T>;
            else
                return new List<T>();
        }

       

        // ========================
        // MÉTODO GENÉRICO DE CRIAÇÃO
        // ========================
        public T Create<T>(T modelo) where T : IModeloComId
        {
            List<T> lista = CarregarLista<T>();
            modelo.Id = ObterProximoId(lista);
            lista.Add(modelo);
            SalvarLista(lista);
            return modelo;
        }

        // ========================
        // MÉTODO GENÉRICO DE CONSULTA
        // ========================
        public List<T> GetAll<T>() where T : IModeloComId
        {
            return CarregarLista<T>();
        }

        // ========================
        // MÉTODO DE ATUALIZAÇÃO DE MATCHUP
        // ========================
        public void UpdateMatchup(MatchupModel matchup)
        {
            List<TournamentModel> torneios = GetAll<TournamentModel>();

            foreach (var torneio in torneios)
            {
                foreach (var rodada in torneio.Rounds)
                {
                    for (int i = 0; i < rodada.Count; i++)
                    {
                        if (rodada[i].Id == matchup.Id)
                        {
                            rodada[i] = matchup;
                        }
                    }
                }
            }

            SalvarLista(torneios);
        }

       
        // Métodos da interface
        public PrizeModel CreatePrize(PrizeModel modelo)
        {
            return Create(modelo);
        }

        public PersonModel CreatePerson(PersonModel modelo)
        {
            return Create(modelo);
        }

        public TeamModel CreateTeam(TeamModel modelo)
        {
            return Create(modelo);
        }

        public TournamentModel CreateTournament(TournamentModel modelo)
        {
            return Create(modelo);
        }

        public List<PersonModel> GetPerson_All()
        {
            return GetAll<PersonModel>();
        }

        public List<TeamModel> GetTeam_All()
        {
            return GetAll<TeamModel>();
        }

        public List<TournamentModel> GetTournament_All()
        {
            return GetAll<TournamentModel>();
        }

    }
}


