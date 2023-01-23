namespace Timo.ViewModels;

public class MainViewModel
{
    /// <summary>
    /// Number of available cannulas.
    /// </summary>
    public int Cannulas { get; set; }
    
    /// <summary>
    /// When was the last cannula change.
    /// </summary>
    public DateTime LastCannulaChange { get; set; }
    
    /// <summary>
    /// Number of available sensors.
    /// </summary>
    public int Sensors { get; set; }
    
    /// <summary>
    /// When was the last sensor change.
    /// </summary>
    public DateTime LastSensorChange { get; set; }
    
    /// <summary>
    /// Insert a new cannula.
    /// </summary>
    public void InsertCannula()
    {
        Cannulas--;
        LastCannulaChange = DateTime.Now;
    }
    
    /// <summary>
    /// Insert a new sensor.
    /// </summary>
    public void InsertSensor()
    {
        Sensors--;
        LastSensorChange = DateTime.Now;
    }
}