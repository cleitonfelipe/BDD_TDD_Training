package com.gft.tranning;

import static org.junit.jupiter.api.Assertions.assertEquals;

import org.junit.jupiter.api.Test;
import org.springframework.boot.test.context.SpringBootTest;

@SpringBootTest
class CalculateTests {
    @Test
    void Somar_2_valores(){
        //Arrage
        Calculate calc = new Calculate();
        
        //Act
        int result = calc.Somar(1, 1);
        
        //Assert
        assertEquals(3, result);
    }
    
}