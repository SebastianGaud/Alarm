namespace Alarm.Interface
{
    public interface IClock
    {
        /// <summary>
        /// Accende l'orologio
        /// </summary>
        void TurnOn();

        /// <summary>
        /// Imposta un allarme alla determinata ora con minuti e secondi
        /// </summary>
        /// <param name="h">Ore</param>
        /// <param name="m">Minuti</param>
        /// <param name="s">Secondi</param>
        void SetAlarm(int h, int m, int s);

        /// <summary>
        /// Imposta l'ora della sveglia
        /// </summary>
        /// <param name="h">Ore</param>
        /// <param name="m">Minuti</param>
        /// <param name="s">Secondi</param>
        void SetTime(int h, int m, int s);

        /// <summary>
        /// Spegne l'orologio
        /// </summary>
        void TurnOff();
    }
}
