using System.Linq;

namespace ChessBrowser.Components
{

    public static class PGNParser
    {

        public static List<ChessGame> parseFileLine(string[] stream)
        {
            List<ChessGame> loadedChessGames = new();
            ChessGame currentGame = new();

            bool parseMoves = false;

            foreach (string line in stream)
            {
                if (line.StartsWith("["))
                {
                    int openQuote = line.IndexOf('"')+1;
                    int closeQuote = line.LastIndexOf('"');
                    string param = line[openQuote..closeQuote];

                    if (line.StartsWith("[Event"))
                    {
                        currentGame.EventName = param;
                    }
                    else if (line.StartsWith("[Site"))
                    {
                        currentGame.Site = param;
                    }
                    else if(line.StartsWith("[Date"))
                    {
                        if(param.Contains("?"))
                            param = DateOnly.MinValue.ToString(); // 0001-01-01

                        currentGame.EventDate = DateOnly.Parse(param);
                    }
                    else if (line.StartsWith("[Round"))
                    {
                        currentGame.Round = param;
                    }
                    else if (line.StartsWith("[White "))
                    {
                        currentGame.WhitePlayer = param;
                    }
                    else if (line.StartsWith("[Black "))
                    {
                        currentGame.BlackPlayer = param;
                    }
                    else if (line.StartsWith("[WhiteElo"))
                    {
                        currentGame.WhiteElo = param;
                    }
                    else if (line.StartsWith("[BlackElo"))
                    {
                        currentGame.BlackElo = param;
                    }
                    else if (line.StartsWith("[Result"))
                    {
                        currentGame.Result = param;
                    }
                    else if (line.StartsWith("[ECO"))
                    {
                        currentGame.EcoCode = param;
                    }
                    else if (line.StartsWith("[EventDate"))
                    {
                        currentGame.EventDate = DateOnly.Parse(param);
                    }
                }
                else if (line.StartsWith("1."))
                {
                    parseMoves = true;
                    currentGame.Moves += line;
                }
                else if (parseMoves && string.IsNullOrEmpty(line))
                {
                    parseMoves = false;
                    loadedChessGames.Add(currentGame);

                    currentGame = new();
                }
                else if (parseMoves)
                {
                    currentGame.Moves += line;
                }
                
            }

            return loadedChessGames;
        }
    }

}