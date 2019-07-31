import { Component } from '@angular/core';
import {lanchesServices} from './services/lanches.services';
import {lanches} from './classes/lanches';
import {ingrediente} from './classes/ingrediente';
import {shopCart} from './classes/shopCart';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'LancheMutantApp';
  lstLanches: lanches[];
  lstLancheIngrediente: ingrediente[];
  lstShopCart: shopCart[] = [];
  valorUnitario: 0;

  constructor(private _lanchesServices: lanchesServices){}

  public getImage(cod): string{

    let imgCard='assets/'+ cod +'.png';
    return imgCard
  }

  ngOnInit(){
    this._lanchesServices.getLanches()
    .subscribe
      (
        data=>
        {
          console.log(data);
          this.lstLanches = data;
        }
      )
    }

  postVendas(){
      var codigosLanches = '';
      for (let x = 0; x < this.lstShopCart.length; x++) {
        codigosLanches += this.lstShopCart[x].codLanche + " ,";
      }
      codigosLanches = codigosLanches.substr(0, codigosLanches.length - 1);
      this._lanchesServices.postVendas(codigosLanches).subscribe
      (
        data=>
        {
          console.log(data);
        }
      );
  }
  postLanches(lan) {
    debugger;
    let descricao = '';
    let valor = 0;

    for (let x = 0; x < lan.Ingredientes.length; x++) {
      descricao += lan.Ingredientes[x].Ingrediente + ", ";
      valor += lan.Ingredientes[x].Valor;
    }
    descricao = descricao.substr(0, descricao.length - 2);

    var obj = new shopCart();
    obj = {
      codLanche: lan.CodLanche,
      lanche: lan.Lanche,
      descricao: descricao,
      valor: valor.toFixed(2),
      valorUnitario:valor,
      quantidade: 1,
      valorTotal: valor
    }
    this.lstShopCart.push(obj);
  }


  totalLanche(): string{
      let retValor = 0;
      for (let x =0; x < this.lstShopCart.length; x++)
      {
        retValor += this.lstShopCart[x].valorTotal;
      }
      return retValor.toFixed(2);
    }

    removeLanche(codLanche){
        let index = this.lstShopCart.findIndex(x => x.codLanche === codLanche );

        this.lstShopCart.splice(index, 1);


    }

    changeQuantidade(event, codLanche){

      let lanche = this.lstShopCart.find(x => x.codLanche === codLanche );
      lanche.valorTotal = event.target.value * lanche.valorUnitario;
    }
}
