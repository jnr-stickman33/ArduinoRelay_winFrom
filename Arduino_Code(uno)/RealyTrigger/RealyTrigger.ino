int data;  

void setup() {  
    Serial.begin(9600);  
    pinMode(13, OUTPUT); 
    pinMode(12, OUTPUT); 
    pinMode(8, OUTPUT); 

}  
void loop() {  
    if (Serial.available()) 
    {  data = Serial.read();  
      if (data == 'A') {
        digitalWrite(13, HIGH),
        digitalWrite(8, HIGH);
        delay(3000);
        digitalWrite(13, LOW),
        digitalWrite(8, LOW);
        }
        if (data == 'B') {
          digitalWrite(8, LOW),
          digitalWrite(12, HIGH),
          digitalWrite(13, LOW);
          delay(3000);
          digitalWrite(8, LOW),
          digitalWrite(12, LOW),
          digitalWrite(13, LOW);
        }
        else {
          digitalWrite(8, LOW),
          digitalWrite(12, LOW),
          digitalWrite(13, LOW);
          
        }
                     
    }  
}  
