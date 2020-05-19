#include <SPI.h>
#include <MFRC522.h>
#include <Servo.h> 
#define SERVO_PIN 8

#define SS_PIN 10
#define RST_PIN 9
MFRC522 mfrc522(SS_PIN, RST_PIN);  
Servo servo;

int ken = 6;
int led = 7;


void DocDuLieu()
{
  if(Serial.available()) 
      { 
      if (Serial.read() == '1') 
       {
        digitalWrite(led,1);
        servo.write(90);    
        delay(1000);
        digitalWrite(led,0);
        } 
      }
}

void setup() 
{
  
  Serial.begin(115200);   
  SPI.begin();      
  mfrc522.PCD_Init();   // Initiate MFRC522
  pinMode(led,OUTPUT);
  pinMode(ken,OUTPUT);
  servo.attach(SERVO_PIN);
}

void loop() 
{
    servo.write(0);
    DocDuLieu();   
  if ( ! mfrc522.PICC_IsNewCardPresent()) 
  {
    return;
  }
  if (mfrc522.PICC_ReadCardSerial()) 
  {    
      String content= "";
      digitalWrite(ken,1);
        for (byte i = 0; i < mfrc522.uid.size; i++) 
        {
           //Serial.print(mfrc522.uid.uidByte[i] < 0x10 ? " 0" : " ");
           //Serial.print(mfrc522.uid.uidByte[i], HEX);
           content.concat(String(mfrc522.uid.uidByte[i] < 0x10 ? "0":""));
           content.concat(String(mfrc522.uid.uidByte[i],HEX));
        }      
      Serial.print(content);
      delay(100);  
      digitalWrite(ken,0);  
      delay(100);
      digitalWrite(ken,1);  
      delay(100);
      digitalWrite(ken,0); 
      DocDuLieu();
  }  
  Serial.println();
  //delay(500);
}
