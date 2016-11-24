#include "Rp6.h"

#define stepsPerRev 2048//4096
#define attackSteps 700
#define recoverSteps 500

byte byteArray[4];
RP6_DIRECTION dir = RP6_FORWARD;
const int buttonHit = 8;
const int buttonGotHit = 9;

const int blue = 10;
const int pink = 11;
const int yellow = 12;
const int orange = 13;

bool attack = true;
bool attackDirection = true;
int steps = 0;
int stepsLeft = 0;
unsigned long lastTick;

String message = "";
bool reading = false;
bool messageComplete = false;

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  Rp6.begin();
  pinMode(buttonHit, INPUT);
  pinMode(buttonGotHit, INPUT);

  pinMode(blue, OUTPUT);
  pinMode(pink, OUTPUT);
  pinMode(yellow, OUTPUT);
  pinMode(orange, OUTPUT);

  //start one attack
  //attack = true;
  //stepsLeft = attackSteps;
}

void loop() {
  // put your main code here, to run repeatedly:
  if (Serial.available() > 0)
  {
    if (Serial.read() == '%')
    {
      Serial.readBytes(byteArray, 3);
    }
    //Serial.println("daar");
    Rp6.moveAtSpeed(byteArray[1], byteArray[2]);
    //Serial.println("RP6Move");
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

    if (byteArray[0] & 2 || attack == true)
    {
      //Serial.println("Hier");
      long timeNow = micros();
      //if (timeNow - lastTick >= 500)
      //{
        AttackTick();
        lastTick = timeNow;
      //}
    }
  }
  if (digitalRead(buttonHit) || digitalRead(buttonGotHit))
  {
    byte respond = 0;
    if (digitalRead(buttonHit))
    {
      respond |= 2;
    }
    if (digitalRead(buttonGotHit))
    {
      respond |= 1;
    }
    Serial.println(respond);
  }
}

void AttackTick()
{
  /*if (stepsLeft >= 0)
  {
    stepperTick(attackDirection);
    stepsLeft--;
  }
  else if (stepsLeft < 0)
  {
    attack = false;
    stepsLeft = recoverSteps;
  }*/
  steps = attackSteps;
  stepperTick(attackDirection);
  steps = recoverSteps;
  stepperTick(!attackDirection);
}

void stepperTick(bool dir) {
  //Serial.println("Test");
  switch (steps)
  {
    case 0:
      digitalWrite(blue, HIGH);
      digitalWrite(pink, HIGH);
      digitalWrite(yellow, LOW);
      digitalWrite(orange, LOW);
      //delay(3);
      break;
    case 1:
      digitalWrite(blue, LOW);
      digitalWrite(pink, HIGH);
      digitalWrite(yellow, HIGH);
      digitalWrite(orange, LOW);
      //delay(3);
      break;
    case 2:
      digitalWrite(blue, LOW);
      digitalWrite(pink, LOW);
      digitalWrite(yellow, HIGH);
      digitalWrite(orange, HIGH);
      //delay(3);
      break;
    case 3:
      digitalWrite(blue, HIGH);
      digitalWrite(pink, LOW);
      digitalWrite(yellow, LOW);
      digitalWrite(orange, HIGH);
      //delay(3);
      break;
  }
  if (!dir)
  {
    steps++;
    if (steps > 3)
    {
      steps = 0;
    }
  }
  else
  {
    steps--;
    if (steps < 0)
    {
      steps = 3;
    }
  }
}
