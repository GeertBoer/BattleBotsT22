void Attack(byte controlbyte)
{
  digitalWrite(ledAttack, controlbyte & 2);
  delay(1000);
  digitalWrite(ledAttack, LOW);
}

