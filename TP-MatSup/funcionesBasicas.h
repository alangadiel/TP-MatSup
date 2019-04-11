#pragma once
class Complejo {
private:
	ComplejoBinomial* binomial = nullptr;
	ComplejoPolar* polar = nullptr;
public:
	ComplejoBinomial GetBinomial() {
		if (binomial == nullptr) {
			//crearlo
		}
		return *binomial;
	}

};

typedef struct ComplejoBinomial {
	float real;
	float imaginaria;

	float mod() {
		return sqrt(pow(real, 2) + pow(imaginaria, 2));
	}

	float arg() {
		float angulo = atan(imaginaria / real);

		if (real >= 0) {
			if (imaginaria >= 0) {		//1er Cuadrante
				return angulo;
			}
			else {						//4to Cuadrante
				return 2 * Math.PI + angulo;
			}
		}
		else {							//2do y 3er Cuadrante
			return Math.PI + angulo;
		}
	}


};

typedef struct ComplejoPolar {
	float modulo;
	float argumento;

	void corregirVuelta() {}

	float real() {
		return r * cos(q);
	}

	float imaginario() {
		return r * sin(q);
	}
};

float Polar_BinomicaRE(float, float);
float Polar_BinomicaIM(float, float);
float Binomica_PolarMODULO(float, float);
float Binomica_PolarARGUMENTO(float, float);
void sumaBINOMICA(int, int, int, int);
void cocientePOLAR(float, float, float, float);
void productoPOLAR(float, float, float, float);
void potenciacionPOLAR(float, float, int);


float Polar_BinomicaRE(float r, float q) {
	return r * cos(q);
}
float Polar_BinomicaIM(float r, float q) {
	return r * sin(q);
}
float Binomica_PolarMODULO(float a, float b) {
	return sqrt(pow(a, 2) + pow(b, 2));
}
float Binomica_PolarARGUMENTO(float a, float b) {
	//verificar angulo de giro
	return 0.0;
}
void sumaBINOMICA(int a1, int b1, int a2, int b2) {
	std::cout << "El resultado de la operacion es: " << a1 + a2 << " + " << b1 + b2 << "j";
}
void cocientePOLAR(float r1, float q1, float r2, float q2) {
	std::cout << "El resultado del cociente es: [" << r1 / r2 << " ;  " << q1 - q2 << "j";
}
void productoPOLAR(float r1, float q1, float r2, float q2) {
	std::cout << "El resultado del producto es: [" << r1 * r2 << " ; " << q1 + q2 << "j";
}
void potenciacionPOLAR(float r, float q, int exponente) { //utiliza formula de De Moivre
	std::cout << "El resultado de la potenciacion es: [" << pow(r, exponente) << " ; " << q * exponente << "j";
}
