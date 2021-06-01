package com.const.func_prog
import scala.language.implicitConversions

trait Semigroup[A] {
  def combine(a: A, b: A): A
}

  object Semigroup {
//    def laws[A: Arbitrary : Shrink](implicit sg: Semigroup[A], p: A => Pretty) = {
//      List(
//        forAll { (a: A, b: A, c: A) => sg.combine(sg.combine(a, b), c) == sg.combine(a, sg.combine(b, c)) }, //associative
//        forAll { (a: A, b: A) => sg.combine(a, b) == sg.combine(b, a) } //commutative
//      )
//    }
  implicit val BigDecimalSemigroup = new Semigroup[BigDecimal] {
    override def combine(x: BigDecimal, y: BigDecimal): BigDecimal = new BigDecimal(x.bigDecimal.add(y.bigDecimal), x.mc)
  }
}

object Laba {
  def main(args: Array[String]): Unit = {
    //Semigroup.laws[BigDecimal].foreach(_.check())
    //val sg = Semigroup.BigDecimalSemigroup
    //forAll { (a: BigDecimal, b: BigDecimal, c: BigDecimal) => sg.combine(me.combine(a, b), c) == sg.combine(a, sg.combine(b, c)) }.check()
    //forAll { (a: BigDecimal, b: BigDecimal) => sg.combine(a,b) == sg.combine(b,a) }.check()
  }
}