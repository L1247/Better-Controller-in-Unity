#region

using Player;
using UnityEngine;

#endregion

namespace Battle
{
    public class MovePlayerHandlerByInput
    {
    #region Private Variables

        private readonly InputState       inputState;
        private readonly PlayerController playerController;

    #endregion

    #region Constructor

        public MovePlayerHandlerByInput(InputState inputState , PlayerController playerController)
        {
            this.inputState       = inputState;
            this.playerController = playerController;
        }

    #endregion

    #region Unity events

        public void Update()
        {
            // if (battleState.IsGamePausing) return;
            var horizontal = inputState.Horizontal;
            var vertical   = inputState.Vertical;

            if (horizontal == 0 && vertical == 0) return;

            var movement = new Vector2(horizontal , vertical) * Time.deltaTime;
            playerController.MovePlayerCharacter(movement);
        }

    #endregion

        // private BattleState battleState;
    }
}