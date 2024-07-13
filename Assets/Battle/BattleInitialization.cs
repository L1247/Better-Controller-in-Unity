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

        private MovePlayerHandlerByInput     movePlayerHandlerByInput;
        private ProcessInputHandler_Keyboard processInputHandlerKeyboard;

        [SerializeField]
        private TMP_Text positionText;

        [SerializeField]
        private Transform playerTransform;

    #endregion

    #region Unity events

        private void Start()
        {
            var inputState       = new InputState();
            var playerMoveView   = new PlayerMoveView(positionText);
            var playerMover      = new PlayerMover(3 , playerTransform);
            var playerController = new PlayerController(playerMover , playerMoveView);
            processInputHandlerKeyboard = new ProcessInputHandler_Keyboard(inputState);
            movePlayerHandlerByInput    = new MovePlayerHandlerByInput(inputState , playerController);
        }

        private void Update()
        {
            processInputHandlerKeyboard.Update();
            movePlayerHandlerByInput.Update();
        }

    #endregion
    }
}