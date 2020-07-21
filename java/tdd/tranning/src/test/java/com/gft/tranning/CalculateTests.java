package com.gft.tranning;

import static org.junit.jupiter.api.Assertions.assertEquals;

import org.junit.jupiter.api.Test;
import org.springframework.boot.test.context.SpringBootTest;

@SpringBootTest
class CalculateTests {
    @Test
    void Somar_2_valores(){
        Calculate calc = new Calculate();

        int result = calc.Somar(1, 1);

        assertEquals(2, result);
    }
    
}