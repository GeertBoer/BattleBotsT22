#include "Rp6.h"
byte byteArray[3];
RP6_DIRECTION dir = RP6_FORWARD;
int buttonHit = 6;
int buttonGotHit = 7;

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  Rp6.begin();
  pinMode(buttonHit, INPUT);
  pinMode(buttonGotHit, INPUT);
}

void loop() {
  // put your main code here, to run repeatedly:
  if (Serial.available() > 0)
  {
    Serial.readBytes(byteArray, 3);
    Rp6.moveAtSpeed(byteArray[1], byteArray[2]);
//    if((byteArray[0] & 1) && (dir == RP6_FORWARD))
//    {
//      dir = RP6_BACKWARD;
//      Rp6.changeDirection(RP6_BACKWARD);
//    }
//    else if(((byteArray[0] & 1) == false )&& (dir == RP6_BACKWARD))
//    {
//      dir = RP6_FORWARD;
//      Rp6.changeDirection(RP6_FORWARD);
//    }
    
    if(byteArray[0] & 2)
    {
      Attack(byteArray[0]);
    }
  }
}
