import com.const.func_prog.Semigroup
import org.scalacheck.Prop.forAll
import org.scalacheck.Properties

object SemigroupSpecification extends Properties("Semigroup") {
  val sg = Semigroup.BigDecimalSemigroup

  property("associative") = forAll { (a: BigDecimal, b: BigDecimal, c: BigDecimal) => sg.combine(sg.combine(a, b), c) == sg.combine(a, sg.combine(b, c)) }
  property("commutative") = forAll { (a: BigDecimal, b: BigDecimal) => sg.combine(a,b) == sg.combine(b,a) }

}