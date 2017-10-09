namespace Alarm.Interface
{
    public interface IDisplay
    {
        /// <summary>
        /// Passate ore minuti e secondi fa vedere il tempo
        /// </summary>
        /// <param name="h">Ore</param>
        /// <param name="m">Minuti</param>
        /// <param name="s">Secondi</param>
        void Show(int h, int m, int s);
    }
}
