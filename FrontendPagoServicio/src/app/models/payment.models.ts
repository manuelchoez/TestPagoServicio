export class Payment {
    constructor(
        public IdPago:number,
        public FechaPago:string,
        public CedulaCliente:string,
        public IdServicio:number,
        public PagoProcesado:string,
        public Mensaje:string,
        public Estado:boolean){

    }
}
