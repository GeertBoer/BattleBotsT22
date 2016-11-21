byte byteArray[3];
int buttonHit = 6;
int buttonGotHit = 7;
int ledAttack = 12;
int ledSpeedRight = 11;
int ledSpeedLeft = 10;
int ledDirection = 9;

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  pinMode(buttonHit, INPUT);
  pinMode(buttonGotHit, INPUT);
  pinMode(ledDirection, OUTPUT);
  pinMode(ledAttack, OUTPUT);
}

void loop() {
  // put your main code here, to run repeatedly:
  if (Serial.available() > 0)
  {
    Serial.readBytes(byteArray, 3);
  }
}
