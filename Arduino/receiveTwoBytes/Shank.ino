void Attack(byte controlbyte)
{
  digitalWrite(ledAttack, controlbyte & 2);
}

