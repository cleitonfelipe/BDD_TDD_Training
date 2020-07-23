package com.gft.tranning;

import static org.junit.jupiter.api.Assertions.assertEquals;
import static org.junit.jupiter.api.Assertions.assertTrue;

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
        assertEquals(2, result);
    }

    @Test
    void Verificar_Se_Entrada_Numero()
    {
        //Arrage
        Calculate calc = new Calculate();
        
        //Act
        boolean result = calc.VerificarInteiro(1);
        
        //Assert
        assertTrue(result);
    }
    
}