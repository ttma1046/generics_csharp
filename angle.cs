struct Angle
{
  public Angle(int degrees, int minutes, int seconds)
  {
      _Degrees = degrees;
      _Minutes = minutes;
      _Seconds = seconds;
  }

  public int Degrees
  {
      get { return _Degrees; }
  }

  private int _Degrees;

  public int MyProperty { get; set; }

  public int MyProperty { get; set; }  
}