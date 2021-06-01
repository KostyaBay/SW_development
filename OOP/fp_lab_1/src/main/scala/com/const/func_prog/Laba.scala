package com.const.func_prog
import scala.language.implicitConversions

trait Semigroup[A] {
  def combine(a: A, b: A): A
}

  object Semigroup {
  implicit val BigDecimalSemigroup = new Semigroup[BigDecimal] {
    override def combine(x: BigDecimal, y: BigDecimal): BigDecimal = new BigDecimal(x.bigDecimal.add(y.bigDecimal), x.mc)
  }
}

object Laba {
  def main(args: Array[String]): Unit = {
  }
}