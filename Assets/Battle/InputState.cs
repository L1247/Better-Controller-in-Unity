namespace Battle
{
    public class InputState
    {
    #region Public Variables

        public float Horizontal { get; private set; }
        public float Vertical   { get; private set; }

    #endregion

    #region Public Methods

        public void SetHorizontal(float value)
        {
            Horizontal = value;
        }

        public void SetVertical(float value)
        {
            Vertical = value;
        }

    #endregion
    }
}