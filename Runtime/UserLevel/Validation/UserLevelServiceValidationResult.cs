using ChainPattern;

namespace RealbizGames.Data
{
    public class UserLevelServiceValidationResult : IAsynPieceResult
    {
        public const string PUBLIC_KEY = "UserLevelServiceValidationResult";

        private bool _success;

        public UserLevelServiceValidationResult(bool success)
        {
            _success = success;
        }

        public bool Success { get => _success; set => _success = value; }

        public string GetKey()
        {
            return PUBLIC_KEY;
        }
    }
}

