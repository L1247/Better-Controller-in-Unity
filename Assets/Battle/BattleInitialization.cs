#region

using Player;
using TMPro;
using UnityEngine;

#endregion

namespace Battle
{
    public class BattleInitialization : MonoBehaviour
    {
    #region Private Variables

        private MovePlayerHandlerByInput movePlayerHandlerByInput;
        private ProcessInputHandler      processInputHandler;

        [SerializeField]
        private TMP_Text positionText;

        [SerializeField]
        private GameObject playerPrefab;

    #endregion

    #region Unity events

        private void Start()
        {
            var inputState       = new InputState();
            var playerMoveView   = new PlayerMoveView(positionText);
            var playerController = new PlayerController(playerMoveView , playerPrefab);
            playerController.CreatePlayer(new Vector2(3 , -1) , 3f);
            // playerController.CreatePlayer(new Vector2(3 , -1) , 3f);
            // processInputHandler = new ProcessInputHandler_Controller(inputState);
            processInputHandler      = new ProcessInputHandler_Keyboard(inputState);
            movePlayerHandlerByInput = new MovePlayerHandlerByInput(inputState , playerController);
        }

        private void Update()
        {
            processInputHandler.ProcessInput();
            movePlayerHandlerByInput.Update();
        }

    #endregion
    }
}