void CheckMessage(byte byteArray, int amountOfBytes)
{ 
  if (Serial.available() > 0)
  {
    if (reading)
    {
      int received = Serial.read();
      if (received == '#')
      {
        reading = false;
        messageComplete = true;
      }
      else if (received == '%')
      {
        message = "";
      }
      else
      {
        message += (char) received;
      }
    }
    else
    {
      if (Serial.read() == '%')
      {
        reading = true;
        message = "";
      }
    }

    if (messageComplete)
    {
      
      messageComplete = false;
    }
  }
}
