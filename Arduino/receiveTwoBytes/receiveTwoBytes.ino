byte moo[2];

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  pinMode(9, OUTPUT);
}

void loop() {
  // put your main code here, to run repeatedly:
  if (Serial.available() > 0)
  {
    Serial.readBytes(moo, 2);
    analogWrite(9, moo[0]);
    analogWrite(10, moo[1]);
  }
}
