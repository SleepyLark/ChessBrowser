namespace ChessBrowser.Components
{
    public class ChessGame
    {
        private string eventName;
        private string site;
        private DateOnly date;
        private string round;
        private string whitePlayer;
        private string blackPlayer;
        private string result;
        private string whiteElo;
        private string blackElo;
        private string ECO;
        private DateOnly eventDate;
        private string moves;

        public ChessGame(string eventName, string site, DateOnly date, string round,
        string whitePlayer, string blackPlayer, string result, string whiteElo,
        string blackElo, string ECO, DateOnly eventDate, string moves)
        {
            this.eventName = eventName;
            this.site = site;
            this.date = date;
            this.round = round;
            this.whitePlayer = whitePlayer;
            this.blackPlayer = blackPlayer;
            this.result = result;
            this.whiteElo = whiteElo;
            this.blackElo = blackElo;
            this.ECO = ECO;
            this.eventDate = eventDate;
            this.moves = moves;
        }

        public ChessGame()
        {

        }

        // Event Name
        public string EventName
        {
            get { return eventName; }
            set { eventName = value; }
        }

        // Site
        public string Site
        {
            get { return site; }
            set { site = value; }
        }

        // Date
        public DateOnly Date
        {
            get { return date; }
            set { date = value; }
        }

        // Round
        public string Round
        {
            get { return round; }
            set { round = value; }
        }

        // White Player
        public string WhitePlayer
        {
            get { return whitePlayer; }
            set { whitePlayer = value; }
        }

        // Black Player
        public string BlackPlayer
        {
            get { return blackPlayer; }
            set { blackPlayer = value; }
        }

        // Result
        public string Result
        {
            get { return result; }
            set { result = value; }
        }

        // White Elo
        public string WhiteElo
        {
            get { return whiteElo; }
            set { whiteElo = value; }
        }

        // Black Elo
        public string BlackElo
        {
            get { return blackElo; }
            set { blackElo = value; }
        }

        // ECO
        public string EcoCode
        {
            get { return ECO; }
            set { ECO = value; }
        }

        // Event Date
        public DateOnly EventDate
        {
            get { return eventDate; }
            set { eventDate = value; }
        }

        // Moves List
        public string Moves
        {
            get { return moves; }
            set { moves = value; }
        }
    }
}
