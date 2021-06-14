using System.Collections.Generic;
using UnityEngine;
using ChainPattern;

namespace RealbizGames.Data
{
    public class UserLevelServiceValidation : IAsynPieceExecutor
    {
        const string TAG = "UserLevelServiceValidation";

        private IUserLevelService _service;

        private UserLevelServiceValidationResult _response;

        public UserLevelServiceValidation(IUserLevelService service)
        {
            _service = service;
        }

        public bool IsDone => _response != null;

        public IAsynPieceResult Result => _response;

        public void Execute(IAsynChainResult data)
        {
            #if UNITY_EDITOR
            Debug.LogFormat("{0} - Execute", TAG);

            UserLevelDTO dto = _service.Get();

            Debug.LogFormat("{0} - {1}", TAG, dto);

            Debug.LogFormat("{0} - End", TAG);
            #endif

            _response = new UserLevelServiceValidationResult(success: true);
        }
    }
}

