using Library1.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Library1
{
    public static class TournamentLogic
    {
        public static void CreateRounds(TournamentModel tournament)
        {
            List<TeamModel> teams = tournament.EnteredTeams;
            int rounds = CalculateRounds(teams.Count);
            int byes = CalculateByes(teams.Count);

            tournament.Rounds = new List<List<MatchupModel>>();

            List<MatchupModel> firstRound = CreateFirstRound(byes, teams);
            tournament.Rounds.Add(firstRound);

            CreateOtherRounds(tournament, rounds);
        }

        private static int CalculateRounds(int teamCount)
        {
            return (int)Math.Ceiling(Math.Log(teamCount, 2));
        }

        private static int CalculateByes(int teamCount)
        {
            int rounds = CalculateRounds(teamCount);
            int totalTeams = (int)Math.Pow(2, rounds);
            return totalTeams - teamCount;
        }

        private static List<MatchupModel> CreateFirstRound(int byes, List<TeamModel> teams)
        {
            List<MatchupModel> output = new List<MatchupModel>();
            MatchupModel current = new MatchupModel();
            current.Entries = new List<MatchupEntryModel>();
            current.MatchupRound = 1;

            foreach (TeamModel team in teams)
            {
                current.Entries.Add(new MatchupEntryModel { TeamCompeting = team });

                if (byes > 0 || current.Entries.Count == 2)
                {
                    current.Winner = byes > 0 ? team : null;
                    byes--;

                    output.Add(current);
                    current = new MatchupModel
                    {
                        Entries = new List<MatchupEntryModel>(),
                        MatchupRound = 1
                    };
                }
            }

            return output;
        }

        private static void CreateOtherRounds(TournamentModel tournament, int rounds)
        {
            int roundNumber = 2;
            List<MatchupModel> previousRound = tournament.Rounds[0];

            while (roundNumber <= rounds)
            {
                List<MatchupModel> round = new List<MatchupModel>();
                MatchupModel current = new MatchupModel
                {
                    Entries = new List<MatchupEntryModel>(),
                    MatchupRound = roundNumber
                };

                foreach (MatchupModel matchup in previousRound)
                {
                    current.Entries.Add(new MatchupEntryModel { ParentMatchup = matchup });

                    if (current.Entries.Count == 2)
                    {
                        round.Add(current);
                        current = new MatchupModel
                        {
                            Entries = new List<MatchupEntryModel>(),
                            MatchupRound = roundNumber
                        };
                    }
                }

                tournament.Rounds.Add(round);
                previousRound = round;
                roundNumber++;
            }
        }
    }
}

