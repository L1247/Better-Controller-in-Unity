#region

using System;
using UnityEngine;

#endregion

namespace Battle
{
    public class ProcessInputHandler_Controller : ProcessInputHandler
    {
    #region Constructor

        public ProcessInputHandler_Controller(InputState inputState)
        {
            throw new NotImplementedException();
        }

    #endregion

    #region Public Methods

        public void ProcessInput()
        {
            throw new NotImplementedException();
        }

    #endregion
    }

    public interface ProcessInputHandler
    {
    #region Public Methods

        void ProcessInput();

    #endregion
    }

    public class ProcessInputHandler_Keyboard : ProcessInputHandler
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

    #region Public Methods

        public void ProcessInput()
        {
            inputState.SetHorizontal(Input.GetAxis("Horizontal"));
            inputState.SetVertical(Input.GetAxis("Vertical"));
        }

    #endregion
    }
}