#region

using UnityEngine;

#endregion

namespace Player
{
    public class PlayerController : MonoBehaviour
    {
    #region Private Variables

        public PlayerMover    mover ;
        public PlayerMoveView moveView;

    #endregion

    #region Unity events

        private void Update()
        {
            var horizontal = Input.GetAxis("Horizontal");
            var vertical   = Input.GetAxis("Vertical");

            if (horizontal == 0 && vertical == 0) return;

            var movement = new Vector2(horizontal , vertical) * Time.deltaTime;
            mover.Move(movement);
            moveView.UpdatePosition(mover.Position);
        }

    #endregion
    }
}