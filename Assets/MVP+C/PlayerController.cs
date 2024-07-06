#region

using UnityEngine;

#endregion

namespace MVP_C
{
    public class PlayerController : MonoBehaviour
    {
    #region Private Variables

        private PlayerMover    mover;
        private PlayerMoveView moveView;

    #endregion

    #region Unity events

        private void Update()
        {
            var horizontal = Input.GetAxis("Horizontal");
            var vertical   = Input.GetAxis("Vertical");

            if (horizontal == 0 && vertical == 0) return;

            var movement = new Vector2(horizontal , vertical);
            mover.Move(movement);
            moveView.Update(movement);
        }

    #endregion
    }
}