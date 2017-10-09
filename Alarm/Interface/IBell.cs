namespace Alarm.Interface
{
    public interface IBell
    {
        /// <summary>
        /// Fa partire la campana
        /// </summary>
        void Start();

        /// <summary>
        /// Ferma la campana
        /// </summary>
        void End();
    }
}
