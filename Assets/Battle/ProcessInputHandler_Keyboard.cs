#region

using UnityEngine;

#endregion

namespace Battle
{
    public class ProcessInputHandler_Keyboard
    {
    #region Private Variables

        private readonly InputState inputState;

    #endregion

    #region Constructor

        public ProcessInputHandler_Keyboard(InputState inputState)
        {
            this.inputState = inputState;
        }

    #endregion

    #region Unity events

        public void Update()
        {
            inputState.SetHorizontal(Input.GetAxis("Horizontal"));
            inputState.SetVertical(Input.GetAxis("Vertical"));
        }

    #endregion
    }
}