#region

using UnityEngine;

#endregion

namespace Player
{
    public class PlayerController
    {
    #region Private Variables

        private readonly PlayerMover    mover;
        private readonly PlayerMoveView moveView;

    #endregion

    #region Constructor

        public PlayerController(PlayerMover mover , PlayerMoveView moveView)
        {
            this.mover    = mover;
            this.moveView = moveView;
        }

    #endregion

    #region Public Methods

        public void MovePlayerCharacter(Vector2 movement)
        {
            mover.Move(movement);
            moveView.UpdatePosition(mover.Position);
        }

    #endregion
    }
}