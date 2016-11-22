byte byteArray[3];

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  pinMode(5, OUTPUT);
  pinMode(6, OUTPUT);
}

void loop() {
  // put your main code here, to run repeatedly:
  if (Serial.available() > 0)
  {
    Serial.readBytes(byteArray, 3);
    analogWrite(5, byteArray[1]);
    analogWrite(6, byteArray[2]);
  }
}
